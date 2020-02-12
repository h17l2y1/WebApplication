export class DropDownView {
    public categories: DropDownViewItem[];

    constructor() {
        this.categories = new Array<DropDownViewItem>();
    }
}

export class DropDownViewItem {
    id: string;
    name: string;
}
