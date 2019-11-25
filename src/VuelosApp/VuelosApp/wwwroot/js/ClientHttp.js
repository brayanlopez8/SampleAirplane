const userAction = async (urlPath, myBody, method) => {
    debugger;
    if (myBody == "") {
        myBody = undefined;
    }
    const response = await fetch(urlPath, {
        method: method,
        body: myBody, // string or object
        headers: {
            'Content-Type': 'application/json'
        }
    });
    const myJson = await response.json(); //extract JSON from the http response
    // do something with myJson
};
