import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { HammerGestureConfig } from '@angular/platform-browser';
import { Url } from 'url';

@Injectable()
export class ConfigService {
  constructor(private http: HttpClient) {}

  public get(url: string, options?: any) { 
    return this.http.get(url, options); 
    } 
}