﻿/// <reference path="Clienthttp.js" />
//import { userAction } from './ClientHttp';

const GetVuelos = async () => {
    await userAction(location.origin + '/api/vuelos', '', 'GET')
        .then((Response) => { console.log(Response); });
};
