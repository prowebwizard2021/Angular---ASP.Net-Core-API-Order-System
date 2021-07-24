import { createReducer, on } from '@ngrx/store';
import * as apiActions from './api.actions';

export const initialState = [];

export function apiReducer(
  state: any = initialState,
  action
) {
  switch (action.type) {
    case apiActions.GET_DATA:
      state = [...state, action.payload];
      return state;
    default:
      return state;
  }
}