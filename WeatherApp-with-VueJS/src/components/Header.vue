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
  if (document.body.classList.contains('dark')) {
    document.body.classList.remove('dark');
    document.body.classList.add('light');
  } else if (document.body.classList.contains('light')) {
    document.body.classList.remove('light');
    document.body.classList.add('dark');
  }
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
.hr-top {
  border: 2px solid red;
  width: 100vw;
  position: absolute;
  top: 4.5rem
}

.toggle-theme {
  position: absolute;
  top: 15px;
  right: 15px;
}

#logo {
  border-radius: 5px;
}
</style>
