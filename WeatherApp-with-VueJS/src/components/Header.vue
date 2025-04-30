<script setup>
import { onMounted } from "vue";

onMounted(() => {document.body.classList.add('light')});

const props = defineProps({
  data: {
    type: Object,
    required: true,
    default: () => ({
      logo: string,
      vueJSUrl: string
    })
  }
});

const toggleTheme = () => {
  // to implement
};
</script>

<template>
  <a
    :href=props.data.vueJSUrl
    target="_blank"
    rel="noreferrer"
    class="text-3xl flex items-center gap-2 absolute top-2 left-10 font-semibold"
  >
    <img :src=props.data.logo class="w-[120px]" id="logo" alt="logo" />
    Weather App with Vue.JS
  </a>
  <div class="icon-button toggle-theme">
    <input
      type="checkbox"
      class="checkbox"
      id="checkbox"
      @click=toggleTheme
    />
    <label
      for="checkbox"
      class="label top-2 right-10"
    >
      <i class="fa-regular fa-sun" style="color: white;"></i>
      <i class="fa-regular fa-moon" style="color: yellow;"></i>
      <div class="ball"></div>
    </label>
  </div>
  <hr class='hr-top' />
</template>

<style scoped>
</style>
