<template>
<div style="width:100%; height:400px; background-color:gray; margin-top:20px">
    <div id="mapContainer" class="basemap">
    </div>
</div>
</template>

<script scoped>
export default {

    name: "baseMap",
    data() {
        return {
            accessToken: "sk.eyJ1Ijoid29yaW5pdW0iLCJhIjoiY2tmOTk4MjVhMGRhejJxb2ZqMmgzcDU0ZSJ9.eMGc2dB7QwrAEFG6T76TNg",
        }
    },
    mounted() {

        var mapboxgl = require('mapbox-gl/dist/mapbox-gl.js');

        mapboxgl.accessToken = this.accessToken;
        new mapboxgl.Map({
            container: 'mapContainer',
            style: 'mapbox://styles/mapbox/streets-v11',

        });
    },

};
</script>

<style scoped>
.basemapd {
    width: 100%;
    height: 100%;
}

.wrapper {
    width: 100%;
    height: 800%;
}
</style>
