<script setup>
import { ref } from 'vue';

import CityInput from './partials/CityInput.vue';
import Loader from './partials/Loader.vue';

const city = ref('');
const data = ref({});
const bodyData = ref([]);
const loading = ref(false);
const notFound = ref(false);
const inputChanges = ref(false);

const handleSearch = async (cityName) => {
  // to implement
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

    <p>Body</p>
  </div>
</div>
</template>

<style scoped>
</style>