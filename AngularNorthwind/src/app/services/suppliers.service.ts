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

  getsuppliers(): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.get(environment.suppliers + endpoint);
  }

  editSupplier(request: Suppliers) {
    let endpoint = 'api/Suppliers';
    return this.http.patch(environment.suppliers + endpoint, request);
  }

  deleteSupplier(id: number): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.delete(environment.suppliers + endpoint + '/' + id);
  }
}
