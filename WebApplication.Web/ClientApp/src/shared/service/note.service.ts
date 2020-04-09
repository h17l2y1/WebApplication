import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {NotesView, NotesViewItem} from '../model/NotesView';


@Injectable({
  providedIn: 'root'
})
export class NoteService {

  readonly rootUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getAllNotes(): Observable<NotesView> {
    return this.http.get<NotesView>(this.rootUrl + 'Note/GetAll');
  }

  public getById(id: string): Observable<NotesViewItem> {
    return this.http.get<NotesViewItem>(this.rootUrl + 'Note/GetById/' + id);
  }

  public add(note: NotesViewItem): Observable<NotesViewItem> {
    return this.http.post<NotesViewItem>(this.rootUrl + 'Note/Add/', note);
  }

  public remove(id: string): Observable<null> {
    return this.http.delete<null>(this.rootUrl + 'Note/Delete/' + id);
  }

  public update(note: NotesViewItem): Observable<NotesViewItem> {
    return this.http.put<NotesViewItem>(this.rootUrl + 'Note/Update/', note);
  }

}
