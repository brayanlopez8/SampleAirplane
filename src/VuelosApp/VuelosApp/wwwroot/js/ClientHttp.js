const userAction = async (urlPath, myBody, method) => {
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
    return myJson;
    // do something with myJson
};
