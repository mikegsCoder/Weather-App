<script setup>
import { ref } from 'vue';
import { getWeatherData } from "../dataProviders/weather";
import { createBodyData } from '../utils/createBodyData';

import CityInput from './partials/CityInput.vue';
import Loader from './partials/Loader.vue';
import NotFound from './partials/NotFound.vue';
import GeneralInfo from './partials/GeneralInfo.vue';

const city = ref('');
const data = ref({});
const bodyData = ref([]);
const loading = ref(false);
const notFound = ref(false);
const inputChanges = ref(false);

const handleSearch = async (cityName) => {
  city.value = cityName;
  if (cityName == '') return;
  
  loading.value = true;
  notFound.value = false
  const weather = await getWeatherData(cityName);

  if (weather) {
    data.value = weather;
    bodyData.value = createBodyData(weather);
  } else {
    data.value = {};
    notFound.value = true;
  }

  loading.value = false;
  inputChanges.value = false;
};

const handleInputChange = () => {
  inputChanges.value = true;
}
</script>

<template>
<div class="">
  <div class="p-5 lg:p-10">
    <CityInput @search="handleSearch" @input="handleInputChange" />
    <Loader v-if="loading"/>
    <NotFound v-if="!loading && !inputChanges && notFound" :data="{city}"/>
    <div 
      v-if="!loading && !inputChanges && !notFound && Object.keys(data).length > 0" 
      class="text-center" role="status"
    >
      <div class="grid ">
        <GeneralInfo :data="data" :key="data.cod"/>
        <!-- To add info cards -->
      </div>
    </div>
  </div>
</div>
</template>

<style scoped>
</style>