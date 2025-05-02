<script setup>
import { ref } from 'vue';

const city = ref('');
const data = ref({});
const bodyData = ref([]);
const loading = ref(false);
const notFound = ref(false);
const inputChanges = ref(false);

</script>

<template>
<div class="">
  <div class="p-5 lg:p-10">
    <p>Body</p>
  </div>
</div>
</template>

<style scoped>
</style>