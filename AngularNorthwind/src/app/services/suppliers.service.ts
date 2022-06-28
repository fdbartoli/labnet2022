import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Suppliers } from '../models/Suppliers';

@Injectable({
  providedIn: 'root',
})
export class SuppliersService {
  constructor(private http: HttpClient) {}

  postSupplier(request: Suppliers) {}
}
