import {Component, OnInit} from '@angular/core';
import {NoteService} from 'src/shared/service/note.service';
import {NotesViewItem} from '../shared/model/NotesView';
import {MatDialog} from '@angular/material';
import {PopupComponent} from './popup/popup.component';
import {Note} from '../shared/model/Note';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent implements OnInit {
  public notes: Array<NotesViewItem>;

  constructor(private noteService: NoteService, public dialog: MatDialog) {
  }

  ngOnInit() {
    this.getAllNotes();
  }

  private getAllNotes(): void {
    this.noteService.getAllNotes().subscribe(response => {
      this.notes = response.notes;
    });
  }

  public openDialog(note: NotesViewItem): void {
    const sharedNote = new Note(note, false);
    const dialogRef = this.dialog.open(PopupComponent, {
      width: '250px',
      data: sharedNote
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        if (result.id) {
          this.noteService.update(result).subscribe(response => {
            const oldNote = this.notes.find(x => x.id === response.id);
            oldNote.name = response.name;
            oldNote.description = response.description;
            oldNote.data = response.data;
          });
          return;
        }
        this.noteService.add(result).subscribe(response => {
          this.notes.push(response);
        });
      }
    });
  }

  public onRemove(id: string) {
    const index = this.notes.findIndex(x => x.id === id);
    this.notes.splice(index, 1);
    this.noteService.remove(id).subscribe();
  }

  public onOpen(id: string): void {
    this.noteService.getById(id).subscribe(response => {
      const sharedNote = new Note(response, true);
      const dialogRef = this.dialog.open(PopupComponent, {
        width: '250px',
        data: sharedNote
      });
    });
  }
}

