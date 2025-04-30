<script setup>
import { 
  logo, 
  vueJSUrl, 
} from "./constants/appConstants";

import Header from './components/Header.vue';
</script>

<template>
  <Header :data="{logo, vueJSUrl}"/>
</template>

<style scoped>
</style>
