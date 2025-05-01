<script setup>
const props = defineProps({
  data: {
    type: Object,
    required: true,
    default: () => ({
      dataProviderUrl: string,
      sourceCodeUrl: string
    })
  }
});
</script>

<template>
  <hr class='hr-bottom' />
  <a 
    :href=props.data.dataProviderUrl 
    target="_blank" 
    rel="noreferrer"
    class="text-3xl font-semibold absolute bottom-5 left-10">
    Data Provider
  </a>
  <a 
    :href=props.data.sourceCodeUrl 
    target="_blank" 
    rel="noreferrer"
    class="text-3xl font-semibold absolute bottom-5 right-10">
    Source Code
  </a>
</template>

<style scoped>
</style>
