import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'CMEWFS',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44363/',
    redirectUri: baseUrl,
    clientId: 'CMEWFS_App',
    responseType: 'code',
    scope: 'offline_access CMEWFS',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44363',
      rootNamespace: 'Kunsheng.CMEWFS',
    },
  },
} as Environment;
