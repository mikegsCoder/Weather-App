<script setup>
const props = defineProps({
  data: {
    type: Object,
    required: true,
    default: () => ({
      city: string
    })
  }
})
</script>

<template>
<div 
  className="border-2 rounded-lg p-2 flex text-center items-center justify-center gap-2 rounded-lg text-4xl"
  id="not-found"
>
  <i class="fa-regular fa-circle-xmark"></i>
  <div>
    <h3 className="flex text-center items-center justify-center gap-2 rounded-lg text-4xl">
      Invalid city name provided: <strong>{{props.data.city}}</strong>
    </h3>
    <h3 className="flex text-center items-center justify-center gap-2 rounded-lg text-3xl">
      Please enter a valid city name!
    </h3>
  </div>
</div>
</template>

<style scoped>
#not-found {
  border: 3px solid red !important;
  color: red;
  margin-top: 5rem;
  padding: 1rem;
}

#not-found>div>h3 {
  margin: 1rem 6rem;
}

i {
  font-size: 110px;
}
</style>