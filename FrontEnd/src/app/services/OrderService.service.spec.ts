/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { OrderServiceService } from './OrderService.service';

describe('Service: OrderService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [OrderServiceService]
    });
  });

  it('should ...', inject([OrderServiceService], (service: OrderServiceService) => {
    expect(service).toBeTruthy();
  }));
});
