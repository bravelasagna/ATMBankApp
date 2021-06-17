function btn_execute_test_ping_api() {

    fetch(ATMBANKAPP_CONFIG_APIURL_GATEWAY_PING).then(function (response) {
	    // The API call was successful!
        return response.text();
    }).then(function (data) {
        // This is the JSON from our response
        console.log(data);
    }).catch(function (err) {
        // There was an error
        console.warn('Something went wrong.', err);
    });

}

function btn_execute_test_doaction_api() {

    let data = {actionKey: "test", actionData: "test-payload"};

    fetch(ATMBANKAPP_CONFIG_APIURL_GATEWAY_TESTACTION, {
        method: "POST", 
        body: JSON.stringify(data)
    }).then(res => {
        console.log("Request complete! response:", res);
    });

}