import {NotesViewItem} from './NotesView';

export class Note {
  public note: NotesViewItem;
  public isOpen: boolean;

  constructor(note: NotesViewItem, isOpen: boolean) {
    this.note = note;
    this.isOpen = isOpen;
  }
}
