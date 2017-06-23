import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public forecasts: WeatherForecast[];
    public boletas: Boleta[];

    constructor(http: Http, @Inject('ORIGIN_URL') originUrl: string) {
        http.get(originUrl + '/api/Ventas').subscribe(result => {
            this.boletas = result.json() as Boleta[];
        });
    }
}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}

interface Boleta {
    id: number;
    numero_boleta: number;
    fecha: any;
    puntos_cantidad: number;
    total: number;
    cliente_id: number;
    usuario_id: number;
}