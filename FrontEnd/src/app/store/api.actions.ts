import { Action } from '@ngrx/store';

export const GET_DATA = 'GET_DATA';

export class GetData implements Action {
    readonly type = GET_DATA;
    constructor(public payload: any) {}
 }