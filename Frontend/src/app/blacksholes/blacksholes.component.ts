import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Component({
  selector: 'app-blacksholes',
  templateUrl: './blacksholes.component.html',
  styleUrls: ['./blacksholes.component.scss']
})
export class BlacksholesComponent implements OnInit {
  model: FuncParam = { S: 10, K: 10, R: 10, T: 10, V: 10 };
  private callUrl = 'api/blacksholes/call';
  private putUrl = 'api/blacksholes/put';
  public callResult = 0;
  public putResult = 0;
  constructor(private http: HttpClient) {
  }

  ngOnInit() {
  }

  private GetParam(obj): HttpParams {
    const params = new HttpParams();
    for (const p in obj) {
      if (obj.hasOwnProperty(p)) {
        params.append(p, obj[p]);
      }
    }
    return params;
  }

  onSubmit(param: FuncParam) {
    const params = new HttpParams()
      .set('S', '10')
      .set('K', param.K)
      .set('R', param.R)
      .set('T', param.T)
      .set('V', param.V);
    console.log(param.S);
    console.log(params.get('S'));
    this.http.get<number>(this.callUrl, { params: params })
      .subscribe(result => {
        this.callResult = result;
      });
    this.http.get<number>(this.putUrl, { params: params })
      .subscribe(result => {
        this.putResult = result;
      });
  }
  onChange(param: FuncParam) {
    const params = new HttpParams()
      .set('S', '10')
      .set('K', param.K)
      .set('R', param.R)
      .set('T', param.T)
      .set('V', param.V);
    console.log(param.S);
    console.log(params.get('S'));
    this.http.get<number>(this.callUrl, { params: params })
      .subscribe(result => {
        this.callResult = result;
      });
    this.http.get<number>(this.putUrl, { params: params })
      .subscribe(result => {
        this.putResult = result;
      });
  }
}
class FuncParam {
  S;
  K;
  R;
  T;
  V;
}
