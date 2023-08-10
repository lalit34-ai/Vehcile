// var map;
// var directionsService;
// var directionsRenderer;

// // check DOM Ready
// function initMap() {
//     // map options
//     var options = {
//         zoom: 12,
//         center: new google.maps.LatLng(12.830554972282913, 80.22355366871653), // centered US
//         mapTypeId: google.maps.MapTypeId.TRANSIT,
//         mapTypeControl: false,
//     };

//     // Initialize the map
//     map = new google.maps.Map(
//         document.getElementById('map_canvas'),
//         options
//     );

//     // Initialize directions service and renderer
//     directionsService = new google.maps.DirectionsService();
//     directionsRenderer = new google.maps.DirectionsRenderer();

//     // Set the directions renderer to the map
//     directionsRenderer.setMap(map);

//     // Add event listener to the form submission
//     $("form").on("submit", function (event) {
//         event.preventDefault();
//         calculateRoute();
//     });

//     // NY and CA sample Lat / Lng
//     var southWest = new google.maps.LatLng(13.007228982418773, 80.22014435111356);
//     var northEast = new google.maps.LatLng(12.847777587252377, 80.22659348862084);
//     var lngSpan = northEast.lng() - southWest.lng();
//     var latSpan = northEast.lat() - southWest.lat();

//     // Set multiple markers
//     for (var i = 0; i < 6; i++) {
//         // Init markers
//         var marker = new google.maps.Marker({
//             position: new google.maps.LatLng(
//                 southWest.lat() + latSpan * Math.random(),
//                 southWest.lng() + lngSpan * Math.random()
//             ),
//             map: map,
//             title: 'Click Me ' + i,
//         });

//         // Process multiple info windows
//         (function (marker, i) {
//             // Add click event
//             google.maps.event.addListener(marker, 'click', function () {
//                 var infowindow = new google.maps.InfoWindow({
//                     content: 'Places!!',
//                 });
//                 infowindow.open(map, marker);
//             });
//         })(marker, i);
//     }
// }

// function calculateRoute() {
//     var pickup = $("select[name=Pickup]").val();
//     var dropOff = $("select[name=DropOff]").val();
//     var date = $("input[name=DOJ]").val();

//     var request = {
//         origin: pickup,
//         destination: dropOff,
//         travelMode: google.maps.TravelMode.DRIVING,
//         drivingOptions: {
//             departureTime: new Date(date),
//             trafficModel: "bestguess",
//         },
//     };

//     directionsService.route(request, function (result, status) {
//         if (status == google.maps.DirectionsStatus.OK) {
//             directionsRenderer.setDirections(result);
//         } else {
//             alert("Error: " + status);
//         }
//     });
// }

// busMap.js
// busMap.js

function initMap() {
    var options = {
        zoom: 12,
        center: new google.maps.LatLng(12.830554972282913, 80.22355366871653), // centered US
        mapTypeId: google.maps.MapTypeId.TRANSIT,
        mapTypeControl: false,
    };

    var map = new google.maps.Map(
        document.getElementById('map_canvas'),
        options
    );

    var southWest = new google.maps.LatLng(13.007228982418773, 80.22014435111356);
    var northEast = new google.maps.LatLng(12.847777587252377, 80.22659348862084);
    var lngSpan = northEast.lng() - southWest.lng();
    var latSpan = northEast.lat() - southWest.lat();

    for (var i = 0; i < 6; i++) {
        var marker = new google.maps.Marker({
            position: new google.maps.LatLng(
                southWest.lat() + latSpan * Math.random(),
                southWest.lng() + lngSpan * Math.random()
            ),
            map: map,
            title: 'Click Me ' + i,
        });

        (function (marker, i) {
            google.maps.event.addListener(marker, 'click', function () {
                infowindow = new google.maps.InfoWindow({
                    content: 'Places!!',
                });
                infowindow.open(map, marker);
            });
        })(marker, i);
    }
}


$(document).ready(function () {
    $("#submit").click(function (e) {
        e.preventDefault(); // Prevent the default form submission
        $("form").submit(); // Manually trigger the form submission
    });
});
    //   $(document).ready(function () {
    //     // execute
    //     (function () {
    //       // map options
    //       var options = {
    //         zoom: 12,
    //         center: new google.maps.LatLng(12.830554972282913, 80.22355366871653), // centered US
    //         mapTypeId: google.maps.MapTypeId.TRANSIT,
    //         mapTypeControl: false,
    //       };

    //       // init map
    //       var map = new google.maps.Map(
    //         document.getElementById('map_canvas'),
    //         options
    //       );

    //       // NY and CA sample Lat / Lng
    //       var southWest = new google.maps.LatLng(13.007228982418773, 80.22014435111356);
    //       var northEast = new google.maps.LatLng(12.847777587252377, 80.22659348862084);
    //       var lngSpan = northEast.lng() - southWest.lng();
    //       var latSpan = northEast.lat() - southWest.lat();

    //       // set multiple marker
    //       for (var i = 0; i <6; i++) {
    //         // init markers
    //         var marker = new google.maps.Marker({
    //           position: new google.maps.LatLng(
    //             southWest.lat() + latSpan * Math.random(),
    //             southWest.lng() + lngSpan * Math.random()
    //           ),
    //           map: map,
    //           title: 'Click Me ' + i,
    //         });

    //         // process multiple info windows
    //         (function (marker, i) {
    //           // add click event
    //           google.maps.event.addListener(marker, 'click', function () {
    //             infowindow = new google.maps.InfoWindow({
    //               content: 'Places!!',
    //             });
    //             infowindow.open(map, marker);
    //           });
    //         })(marker, i);
    //       }
    //     })();
    //   });
    