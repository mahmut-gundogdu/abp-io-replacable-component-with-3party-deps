import {AuthService, ReplaceableComponentsService} from '@abp/ng.core';
import { Component } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';
import {eTenantManagementComponents} from "@abp/ng.tenant-management";
import {MyTenantComponent} from "../my-tenant/my-tenant.component";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }

  constructor(private oAuthService: OAuthService,
              private authService: AuthService,
              private replaceableComponentsService:ReplaceableComponentsService) {
    this.replaceableComponentsService.add({
      component: MyTenantComponent,
      key: eTenantManagementComponents.Tenants
    })
  }

  login() {
    this.authService.navigateToLogin();
  }
}
