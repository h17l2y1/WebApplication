export class NotesView {
  public notes: Array<NotesViewItem>;
}

export class NotesViewItem {
  public id: string;
  public name: string;
  public description: string;
  public data: string;
}
