﻿var blazorStore = window.MinhasNoticias || {};
blazorStore.mainBodyInstance = null;

const bc = new BroadcastChannel('blazor-store-channel');
bc.onmessage = function (message) {
    if (message && message.data == "new-version-found") {
        notifyAppUpdateToUser();
    } else if (message && message.data == "reload-page") {
        setTimeout(function () {
            //location.reload();
            window.location.href = window.location.href;
        }, 500);
    }
}

function notifyAppUpdateToUser() {
    setTimeout(function () {
        if (blazorStore.mainBodyInstance) {
            blazorStore.mainBodyInstance.invokeMethodAsync('ShowUpdateVersion').then(function () { }, function (er) {
                //setTimeout(notifyAppUpdateToUser, 2000);
            });
        }
    }, 2000);
}
blazorStore.onUserUpdate = function () {
    setTimeout(function () {
        bc.postMessage("skip-waiting");
    }, 300);
}

var mainBodyInstance;
function setRef(ref) {
    blazorStore.mainBodyInstance = ref;
}