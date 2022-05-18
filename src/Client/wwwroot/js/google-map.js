var resolveCallbacks = [];
var rejectCallbacks = [];

window.MinhasNoticias = {
    loadGoogleMaps: function (defaultView, apiKey, resolve, reject) {
        resolveCallbacks.push(resolve);
        rejectCallbacks.push(reject);

        if (defaultView['rz_map_init']) {
            return;
        }

        defaultView['rz_map_init'] = function () {
            for (var i = 0; i < resolveCallbacks.length; i++) {
                resolveCallbacks[i](defaultView.google);
            }
        };

        var document = defaultView.document;
        var script = document.createElement('script');

        script.src =
            'https://maps.googleapis.com/maps/api/js?' +
            (apiKey ? 'key=' + apiKey + '&' : '') +
            'callback=rz_map_init';

        script.async = true;
        script.defer = true;
        script.onerror = function (err) {
            for (var i = 0; i < rejectCallbacks.length; i++) {
                rejectCallbacks[i](err);
            }
        };

        document.body.appendChild(script);
    },
    createMap: function (wrapper, ref, id, apiKey, zoom, center, markers) {
        var api = function () {
            var defaultView = document.defaultView;

            return new Promise(function (resolve, reject) {
                if (defaultView.google && defaultView.google.maps) {
                    return resolve(defaultView.google);
                }

                MinhasNoticias.loadGoogleMaps(defaultView, apiKey, resolve, reject);
            });
        };

        api().then(function (google) {
            MinhasNoticias[id] = ref;
            MinhasNoticias[id].google = google;

            MinhasNoticias[id].instance = new google.maps.Map(wrapper, {
                center: center,
                zoom: zoom
            });

            MinhasNoticias[id].instance.addListener('click', function (e) {
                MinhasNoticias[id].invokeMethodAsync('GoogleMap.OnMapClick', {
                    Position: { Lat: e.latLng.lat(), Lng: e.latLng.lng() }
                });
            });

            MinhasNoticias.updateMap(id, zoom, center, markers);
        });
    },
    updateMap: function (id, zoom, center, markers) {
        if (MinhasNoticias[id] && MinhasNoticias[id].instance) {
            if (MinhasNoticias[id].instance.markers && MinhasNoticias[id].instance.markers.length) {
                for (var i = 0; i < MinhasNoticias[id].instance.markers.length; i++) {
                    MinhasNoticias[id].instance.markers[i].setMap(null);
                }
            }

            MinhasNoticias[id].instance.markers = [];

            markers.forEach(function (m) {
                var marker = new this.google.maps.Marker({
                    position: m.position,
                    title: m.title,
                    label: m.label
                });

                marker.addListener('click', function (e) {
                    MinhasNoticias[id].invokeMethodAsync('GoogleMap.OnMarkerClick', {
                        Title: marker.title,
                        Label: marker.label,
                        Position: marker.position
                    });
                });

                marker.setMap(MinhasNoticias[id].instance);

                MinhasNoticias[id].instance.markers.push(marker);
            });

            MinhasNoticias[id].instance.setZoom(zoom);

            MinhasNoticias[id].instance.setCenter(center);
        }
    },
    destroyMap: function (id) {
        if (MinhasNoticias[id].instance) {
            delete MinhasNoticias[id].instance;
        }
    },
};