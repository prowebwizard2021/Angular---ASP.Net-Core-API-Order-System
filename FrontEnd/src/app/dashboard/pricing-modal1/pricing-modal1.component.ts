import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'pricing-modal1',
  templateUrl: './pricing-modal1.component.html',
  styleUrls: ['./pricing-modal1.component.css']
})
export class PricingModal1Component {
    type: any;
    markup: any;
    currency: any;
    rate: any;
    constructor(
        public dialogRef: MatDialogRef<PricingModal1Component>,
        @Inject(MAT_DIALOG_DATA) public data: any
    ) {
        console.log("dataPass: ", data)
        if (data.isEdit) {
            this.type = data.data.type
            this.markup = data.data.markup
            this.currency = data.data.currency
            this.rate = data.data.rate
        }
    }
    
    onNoClick(): void {
        this.dialogRef.close();
    }
    saveData() {
        this.dialogRef.close({
            type: this.type, 
            markup: this.markup, 
            currency: this.currency, 
            rate: this.rate
        })
    }
}
