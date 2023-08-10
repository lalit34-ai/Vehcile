
// check DOM Ready
$(document).ready(function () {
    // execute
    (function () {
        // map options
        var options = {
            zoom: 12,
            center: new google.maps.LatLng(12.830554972282913, 80.22355366871653), // centered US
            mapTypeId: google.maps.MapTypeId.TRANSIT,
            mapTypeControl: false,
        };

        // init map
        var map = new google.maps.Map(
            document.getElementById('map_canvas'),
            options
        );

        // NY and CA sample Lat / Lng
        var southWest = new google.maps.LatLng(13.007228982418773, 80.22014435111356);
        var northEast = new google.maps.LatLng(12.847777587252377, 80.22659348862084);
        var lngSpan = northEast.lng() - southWest.lng();
        var latSpan = northEast.lat() - southWest.lat();

        // set multiple marker
        for (var i = 0; i < 6; i++) {
            // init markers
            var marker = new google.maps.Marker({
                position: new google.maps.LatLng(
                    southWest.lat() + latSpan * Math.random(),
                    southWest.lng() + lngSpan * Math.random()
                ),
                map: map,
                title: 'Click Me ' + i,
            });

            // process multiple info windows
            (function (marker, i) {
                // add click event
                google.maps.event.addListener(marker, 'click', function () {
                    infowindow = new google.maps.InfoWindow({
                        content: 'Places!!',
                    });
                    infowindow.open(map, marker);
                });
            })(marker, i);
        }
    })();
});
