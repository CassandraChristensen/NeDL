import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { firstValueFrom } from 'rxjs';
import { ShoppingListItem } from './ShoppingListItem';

@Injectable({
  providedIn: 'root'
})
export class BackendService {
  constructor(private http: HttpClient) {}

  async shoppingList(): Promise<ShoppingListItem[]> {
    return firstValueFrom(
      this.http.get<ShoppingListItem[]>('https://localhost:7209/ShoppingList')
    );
  }
}