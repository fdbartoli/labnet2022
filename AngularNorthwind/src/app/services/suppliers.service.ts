import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Suppliers } from '../models/Suppliers';

@Injectable({
  providedIn: 'root',
})
export class SuppliersService {
  constructor(private http: HttpClient) {}

  postSupplier(request: Suppliers): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.post(environment.suppliers + endpoint, request);
  }
}
