import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ProductsView } from '../model/product.view';
import { AddProductRequest } from '../model/add-product-request.view';
import { GetProductByCategoryIdView } from '../model/GetProductByCategoryId.view';
import { AddProductResponse } from '../model/add-product-response.view';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  readonly rootUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getProducts(model: GetProductByCategoryIdView): Observable<ProductsView> {
    return this.http.post<ProductsView>(this.rootUrl + 'Product/GetProducts', model);
  }

  public addProduct(model: AddProductRequest): Observable<AddProductResponse> {
    return this.http.post<AddProductResponse>(this.rootUrl + 'Product/AddProduct', model);
  }

}
