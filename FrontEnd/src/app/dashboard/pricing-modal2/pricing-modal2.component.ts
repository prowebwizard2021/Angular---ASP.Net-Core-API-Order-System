import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'pricing-modal2',
  templateUrl: './pricing-modal2.component.html',
  styleUrls: ['./pricing-modal2.component.css']
})
export class PricingModal2Component {
    type: any;
    markdown: any;
    currency: any;
    rate: any;
    constructor(
        public dialogRef: MatDialogRef<PricingModal2Component>,
        @Inject(MAT_DIALOG_DATA) public data: any
    ) {
        console.log("dataPass: ", data)
        if (data.isEdit) {
            this.type = data.data.type
            this.markdown = data.data.markdown
            this.currency = data.data.currency
            this.rate = data.data.rate
        }
    }
    
    onNoClick(): void {
        this.dialogRef.close();
    }
    
    saveData() {
        this.dialogRef.close({
            type :this.type, 
            markdown: this.markdown, 
            currency: this.currency, 
            rate: this.rate })
    }
}