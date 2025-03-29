import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { provideClientHydration } from '@angular/platform-browser';
import { provideHttpClient, withFetch, withInterceptors } from '@angular/common/http';
import { provideAnimations } from '@angular/platform-browser/animations';
import { provideToastr} from 'ngx-toastr'
import { errorInterceptor } from './_interceptors/error.interceptor';

export const appConfig: ApplicationConfig = {
  providers: [
    provideZoneChangeDetection({ eventCoalescing: true }), 
    provideHttpClient(...[withInterceptors([errorInterceptor])]),
    provideAnimations(),
    provideRouter(routes), 
    provideToastr({
      positionClass: 'toast-bottom-right'
    }), // Toastr providers
    provideClientHydration()]
};


