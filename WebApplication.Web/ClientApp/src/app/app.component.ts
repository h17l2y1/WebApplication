import { Component, OnInit } from '@angular/core';
import { DropDownService } from 'src/shared/service/dropdown.service';
import { ProductService } from 'src/shared/service/product.service';
import { DropDownView } from 'src/shared/model/dropdown.view';
import { ProductsView } from 'src/shared/model/product.view';
import { AddProductView } from 'src/shared/model/add-product.view';
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
  public addProductView: AddProductView;
  public dropDowmForm: FormGroup;
  public productByCategoryIdView: GetProductByCategoryIdView;

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
    this.productService.addProduct(this.addProductView).subscribe(response => {
      const c = response;
    });
  }

}
