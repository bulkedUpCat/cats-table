import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cat } from '../models/cat';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CatsService {

  constructor(private http: HttpClient) { }

  getAllCats(): Observable<Cat[]>{
    return this.http.get<Cat[]>(environment.apiUrl + 'cats');
  }
}
