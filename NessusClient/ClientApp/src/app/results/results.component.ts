import { Component, Inject, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { faTrash } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-results',
  templateUrl: './results.component.html',
})
export class ResultsComponent {
  faTrash = faTrash;

  constructor(
    private http: HttpClient, @Inject('BASE_URL')
    private baseUrl: string,
    private toastr: ToastrService
  ) {
    this.loadResults();
  }

  public results: Result[] = [];
  public resultsFiltered: Result[] = [];
  public host: string = '';

  public filter() {
    this.resultsFiltered = this.results.filter(s => s.hostName.includes(this.host));
  }

  public delete(scan: Result) {
    this.http.delete(this.baseUrl + 'nessus/results/' + scan.id).subscribe({
      next: () => this.toastr.success('Scan deleted', 'Success'),
      error: err => this.toastr.error('Error'),
      complete: () => {
        this.loadResults();
      },
    });
  }

  public loadResults() {
    this.http.get<Result[]>(this.baseUrl + 'nessus/results').subscribe({
      next: result => {
        this.results = result;
        this.resultsFiltered = result;
      },
      error: err => this.toastr.error('Error'),
    });
  }

  public export() {
    let content = '';
    this.resultsFiltered.forEach(res => {
      content +=
        res.id + ","
        + res.hostName + ','
        + res.scanDate + ',\"'
        + res.output.replace(/\"\'/g, ' ').replace(/(?:\r\n|\r|\n)/g, ' ') + '\",'
        + res.severity + "\r\n";
    });

    const file = new window.Blob([content], { type: "text/plain;charset=utf-8" });

    const downloadAncher = document.createElement("a");
    downloadAncher.style.display = "none";

    const fileURL = URL.createObjectURL(file);
    downloadAncher.href = fileURL;
    downloadAncher.download = "export.csv";
    downloadAncher.click();
  }

}

interface Result {
  id: number;
  hostName: string;
  scanDate: string;
  output: string;
  severity: string;
}
