import { Component, OnInit } from '@angular/core';
import { DropDownService } from 'src/shared/service/dropdown.service';
import { ProductService } from 'src/shared/service/product.service';
import { DropDownView } from 'src/shared/model/dropdown.view';
import { ProductsView, ProductsViewItem } from 'src/shared/model/product.view';
import { AddProductRequest } from 'src/shared/model/add-product-request.view';
import { FormGroup, FormControl } from '@angular/forms';
import { GetProductByCategoryIdView } from 'src/shared/model/GetProductByCategoryId.view';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  title = 'ClientApp';

  public dropDownView: DropDownView;
  public productsView: ProductsView;
  public addProductView: AddProductRequest;
  public dropDowmForm: FormGroup;
  public addProductForm: FormGroup;
  public productByCategoryIdView: GetProductByCategoryIdView;
  public newItem: boolean;

  constructor(private dropDownService: DropDownService, private productService: ProductService) {
  }

  ngOnInit() {
    this.initDropDown();
  }

  private initDropDown(): void {
    this.dropDownService.getAll().subscribe(response => {
      this.dropDownView = response;

      this.dropDowmForm = new FormGroup({
        categories: new FormControl(''),
      });

      this.addProductForm = new FormGroup({
        name: new FormControl(''),
        categoryId: new FormControl(''),
      });

      this.getProducts();
    });
  }

  private getProducts(): void {
    this.productByCategoryIdView = new GetProductByCategoryIdView();
    this.productByCategoryIdView.categoryId = this.dropDowmForm.controls.categories.value.id;
    this.productService.getProducts(this.productByCategoryIdView).subscribe(response => {
      this.productsView = response;
    });
  }

  private addProduct(): void {
    this.addProductView = new AddProductRequest();
    this.addProductView.name = this.addProductForm.controls.name.value;
    this.addProductView.categoryId = this.dropDowmForm.controls.categories.value.id;

    this.productService.addProduct(this.addProductView).subscribe(response => {
      this.openCloseForm();

      const newProduct = new ProductsViewItem()
      newProduct.name = response.name;
      newProduct.id = response.id;
      this.productsView.products.push(newProduct)
    });
  }

  private openCloseForm(){
    this.newItem = !this.newItem;
  }

  public getCategoryById(id: string): string {
    const name = this.dropDownView.categories.find(x=>x.id == id).name;
    return name;
  }

}
