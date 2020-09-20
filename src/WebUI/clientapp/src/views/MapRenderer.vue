<template>
<div class="row">
    <div id="map" style="width:100%; height:800px; margin-top:10px"></div>
</div>
</template>

<script scoped>
import mapboxgl from "mapbox-gl";
export default {
    name: "baseMap",
    data() {
        return {
            accessToken: "sk.eyJ1Ijoid29yaW5pdW0iLCJhIjoiY2tmOTk4MjVhMGRhejJxb2ZqMmgzcDU0ZSJ9.eMGc2dB7QwrAEFG6T76TNg",
        };
    },
    mounted() {
        mapboxgl.accessToken =
            "pk.eyJ1Ijoid29yaW5pdW0iLCJhIjoiY2tmOTZ5cm15MGoxYTJzbWFpbG1lNmdxciJ9.k8sYQdig6kkwA3OMqKc_fQ";
        new mapboxgl.Map({
            container: "map",
            style: "mapbox://styles/mapbox/streets-v11", // stylesheet location
            center: [-74.5, 40], // starting position [lng, lat]
            zoom: 9, // starting zoom
        });
    },
};
</script>

<style scoped>
.basemapd {
    width: 100%;
    height: 100%;
}
</style>
