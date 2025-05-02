<script setup>
import { 
  logo, 
  vueJSUrl, 
  dataProviderUrl, 
  sourceCodeUrl 
} from "./constants/appConstants";

import Header from './components/Header.vue';
import Body from './components/Body.vue';
import Footer from './components/Footer.vue';
</script>

<template>
  <Header :data="{logo, vueJSUrl}"/>
  <Body />
  <Footer :data="{dataProviderUrl, sourceCodeUrl}"/>
</template>

<style scoped>
</style>
