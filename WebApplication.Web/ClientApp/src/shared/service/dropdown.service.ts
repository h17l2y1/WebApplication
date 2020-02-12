import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { DropDownView } from '../model/dropdown.view';

@Injectable({
  providedIn: 'root'
})
export class DropDownService {

  readonly rootUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getAll(): Observable<DropDownView> {
    return this.http.get<DropDownView>(this.rootUrl + 'DropDown/GetCategories');
  }

}
