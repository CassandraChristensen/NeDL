import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarouselPicsComponent } from './carousel-pics.component';

describe('CarouselPicsComponent', () => {
  let component: CarouselPicsComponent;
  let fixture: ComponentFixture<CarouselPicsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarouselPicsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CarouselPicsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
