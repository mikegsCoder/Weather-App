<script setup>
const props = defineProps({
  data: {
    type: Object,
    required: true,
    default: () => ({
      icon: string,
      value: number,
      units: string,
      text: string
    })
  }
})
</script>

<template>
<div class="border-2 rounded-lg p-2">
  <h3 class="flex text-center items-center justify-center gap-2 rounded-lg text-2xl">
    <i :class="props.data.icon"></i>
    {{props.data.text + ': '}}
    {{props.data.value + '' + props.data.units}}
  </h3>
</div>
</template>

<style scoped>
</style>