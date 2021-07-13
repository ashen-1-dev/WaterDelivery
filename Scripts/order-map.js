var addresses = [];

@foreach(var d in Model)
{
    @: addresses.push("г. Томск " + "@d.UserAddress.Address");
}
console.log(addresses);
function initMap() {

    var map = new google.maps.Map(document.getElementById('map'), {
        center: new google.maps.LatLng(56.485867, 84.968000),
        zoom: 10
    });
    geocoder = new google.maps.Geocoder();
    addresses.forEach(n => codeAddress(n, geocoder, map));
}
function codeAddress(address, geocoder, map) {
    const infoWindow = new google.maps.InfoWindow();
    geocoder.geocode({ address }, function (results, status) {
        if (status === 'OK') {

            const marker = new google.maps.Marker({
                map: map,
                position: results[0].geometry.location,
            });
            marker.addListener("click", () => {
                infoWindow.close();
                infoWindow.setContent(address);
                infoWindow.open(marker.getMap(), marker);
            })
        } else {
            alert('Geocode was not successful for the following reason: ' + status);
        }
    });
}