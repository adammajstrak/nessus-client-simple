import { Component, Inject, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { faDownload } from '@fortawesome/free-solid-svg-icons';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-scans',
  templateUrl: './scans.component.html',
})
export class ScansComponent {
  faDownload = faDownload;
  public scans: Scan[] = [];

  constructor(
    private http: HttpClient, @Inject('BASE_URL')
    private baseUrl: string,
    private toastr: ToastrService
    ) {
    this.getAllScans();
  }

  canCreateScan: boolean = true;
  canDownload: boolean = true;

  private getAllScans() {
    this.http.get<Scan[]>(this.baseUrl + 'nessus/scans').subscribe({
      next: result => this.scans = result,
      error: err => this.toastr.error('Error'),
    });
  }

  public createScan() {
    this.canCreateScan = false;

    this.http.post(this.baseUrl + 'nessus/scans', {}).subscribe({
      error: err => this.toastr.error('Error'),
      complete: () => {
        this.canCreateScan = true; this.getAllScans();
      },
      next: () => this.toastr.success('Scan created', 'Success'),
    });
  }

  public loadScan(scan: Scan) {
    this.canDownload = false;
    this.http.post(this.baseUrl + 'nessus/scans/load', scan).subscribe({
      next: () => this.toastr.success('Scan downloaded', 'Success'),
      error: err => this.toastr.error('Error'),
      complete: () => {
         this.canDownload = true;
      },
    });
  }
}

interface Scan {
  id: number;
  name: string;
  status: string;
}
