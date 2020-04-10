import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {NotesViewItem} from '../../shared/model/NotesView';
import {Note} from '../../shared/model/Note';

@Component({
  selector: 'app-popup',
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.scss']
})
export class PopupComponent implements OnInit {

  public noteForm: FormGroup;
  public isOpen: boolean;

  constructor(public dialogRef: MatDialogRef<PopupComponent>,
              @Inject(MAT_DIALOG_DATA) public data: Note) {
  }

  ngOnInit() {
    this.isOpen = this.data.isOpen;
    this.noteForm = new FormGroup({
      id: new FormControl(this.data.note ? this.data.note.id : ''),
      name: new FormControl(this.data.note ? this.data.note.name : '', Validators.required),
      description: new FormControl(this.data.note ? this.data.note.description : '', Validators.required),
      data: new FormControl(this.data.note ? this.data.note.data : '', Validators.required)
    });
    if (this.isOpen) {
      this.noteForm.controls.name.disable();
      this.noteForm.controls.description.disable();
      this.noteForm.controls.data.disable();
    }
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOk(): void {
    if (this.noteForm.controls.name.errors ||
        this.noteForm.controls.description.errors.required ||
        this.noteForm.controls.data.errors.required) {
      return;
    }

    const note = new NotesViewItem();
    note.id = this.noteForm.controls.id.value;
    note.name = this.noteForm.controls.name.value;
    note.description = this.noteForm.controls.description.value;
    note.data = this.noteForm.controls.data.value;
    this.dialogRef.close(note);
  }


}
