import { Component, OnInit } from '@angular/core';
import { CatsService } from '../data-access/cats.service';
import { Cat } from '../models/cat';
import { error } from 'console';

@Component({
  selector: 'app-cats-table',
  templateUrl: './cats-table.component.html',
  styleUrls: ['./cats-table.component.scss']
})
export class CatsTableComponent implements OnInit {
  cats: Cat[] = [];

  constructor(private catsService: CatsService) { }

  ngOnInit(): void {
    this.getAllCats();
  }

  getAllCats(){
    this.catsService.getAllCats().subscribe({
      next: x => this.cats = x,
      error: err => console.log(err)
    })
  }
}
