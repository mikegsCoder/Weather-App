<script setup>
import { ref } from 'vue';

const emit = defineEmits(['search', 'input']);
const city = ref('');

const handleChangeInput = (e) => {
  city.value = e.target.value;
  emit('input');
};

const handleClick = () => {
  const cityName = city.value;
  emit('search', cityName);
};
</script>

<template>
<div class="h-56 flex flex-col items-center justify-center ">
  <div class="text-black grid gap-5">
    <input
      type="text"
      class="text-2xl bg-transparent outline-none border-b-2 w-96 h-12 pl-2 pr-2 capitalize"
      placeholder="Enter Your City"
      @value=city.value
      @input="handleChangeInput"
    />
    <button class="bn3" type="submit" @click="handleClick">
      Search
    </button>
  </div>
</div>
</template>

<style scoped>
</style>