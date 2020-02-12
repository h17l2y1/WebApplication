export class ProductsView {
    public products: ProductsViewItem[];

    constructor() {
        this.products = new Array<ProductsViewItem>();
    }
}

export class ProductsViewItem {
    id: string;
    name: string;
}
