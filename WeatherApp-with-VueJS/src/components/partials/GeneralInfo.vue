<script setup>
const props = defineProps({
  data: {
    type: Object,
    required: true,
    default: () => ({
      weather: [
        {
          id: number,
          main: string,
          description: string,
          icon: string,
        }
      ],
      base: string,
      main: {
        temp: number,
        feels_like: number,
        temp_min: number,
        temp_max: number,
        pressure: number,
        humidity: number,
        sea_level: number,
        grnd_level: number,
      },
      visibility: number,
      wind: {
        speed: number,
        deg: number,
      },
      clouds: {
        all: number,
      },
      dt: number,
      sys: {
        type: number,
        id: number,
        country: string,
        sunrise: number,
        sunset: number,
      },
      timezone: number,
      id: number,
      name: string,
      cod: number,
    })
  }
})
</script>

<template>
<div class="flex flex-col items-center justify-center">
  <h5 class="text-5xl flex items-center gap-5">
    <img 
      class="object-contain" 
      :src="`http://openweathermap.org/img/wn/${props.data?.weather[0]?.icon}@2x.png`"
      alt="weather-icon" />
    <span>
      {{props.data?.name}},<span> {{props.data?.sys?.country}}</span>
    </span>
  </h5>
  <h2 class="text-3xl capitalize">
    {{props.data?.weather[0]?.description}}
  </h2>
</div>
<h6 class="text-7xl gap-2 mb-5 lg:grid">
  {{~~(props.data?.main?.temp - 273.15).toFixed(2)}}°C
  <span class="text-lg text-3xl">
    Feels Like:
    {{' ' + (~~(props.data?.main?.feels_like - 273.15).toFixed(2) - 1)}}°C
  </span>
</h6>
</template>

<style scoped>
</style>