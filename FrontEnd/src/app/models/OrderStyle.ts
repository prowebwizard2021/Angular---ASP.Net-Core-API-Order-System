import { Short } from './Short';
import { License } from './License';
export interface OrderStyle {
  id: number;
  title: string;
  quantityPlaced: number;
  quantityOrdered: number;
  purchasePrice1: number;
  purchasePrice2: number;
  purchasePrice3: number;
  currency: Short;
  currencies: Short[];
  exchangeRatePurchasePrice: number;
  rateOfDutyPuchasePrice: number;
  eKAufschlag: number;
  currencyEKAufschlag: Short;
  vKGP: number;
  vKGPNachLB: number;
  currencyVK: Short[];
  exchangeRateVK: number;
  eKNotFixed: boolean;
  licenses: License[];
  allLicenses: License[];
}
