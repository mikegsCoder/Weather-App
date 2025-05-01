<script setup>
import { 
  logo, 
  vueJSUrl, 
  dataProviderUrl, 
  sourceCodeUrl 
} from "./constants/appConstants";

import Header from './components/Header.vue';
import Footer from './components/Footer.vue';
</script>

<template>
  <Header :data="{logo, vueJSUrl}"/>
  <Footer :data="{dataProviderUrl, sourceCodeUrl}"/>
</template>

<style scoped>
</style>
