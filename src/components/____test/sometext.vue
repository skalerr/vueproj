<template>
  <div>
    <vue-slider v-model="myNumber" :color="getColor" track-color="#FEFEFE" />
    <input :value="Price" @input="$emit('update:Price', $event.target.value)" />
    <!-- Старый ползунок дня -->
    <!-- <input type="range" min="1" max="30" step="1" v-model.number="day" /> -->
    <!-- старый слайдер -->
    <!-- <input
     class="ranger"
     type="range"
     min="1000"
     max="30000"
     step="1000"
     v-model.number="Price"
   /> -->
    <!--  слайдер -->
    <vue3-slider
      v-model="Price"
      color="#198754"
      track-color="#aefbc5"
      :max="30000"
      :step="1"
      :tooltip="true"
      tooltipText="%v"
      tooltipColor="##fb278d"
      tooltipTextColor="#fb278d"
      :height="20"
    />
    <vue3-slider
      v-model="day"
      color="#198754"
      track-color="#aefbc5"
      :max="30"
      :step="1"
      :tooltip="true"
      tooltipText="%v"
      tooltipColor="##fb278d"
      tooltipTextColor="#fb278d"
      :height="20"
    />
  </div>
</template>
<input :value="Price" @input="$emit('update:Price', $event.target.value)" />
<!-- Старый ползунок дня -->
<!-- <input type="range" min="1" max="30" step="1" v-model.number="day" /> -->
<!-- старый слайдер -->
<!-- <input
                        class="ranger"
                        type="range"
                        min="1000"
                        max="30000"
                        step="1000"
                        v-model.number="Price"
                      /> -->
<script>
import slider from "vue3-slider"
import { computed, ref, reactive } from "vue"
export default {
  components: {
    "vue-slider": slider,
  },
  setup() {
    const myNumber = ref(0)

    const mylist = reactive([
      { progress: 10, color: "#e76f51" },
      { progress: 40, color: "#f4a261" },
      { progress: 60, color: "#e9c46a" },
      { progress: 80, color: "#2a9d8f" },
    ])

    //retrieve all progress values from prop
    const progressvalues = mylist.map((pro) => {
      return pro.progress
    })

    //finds closest value for progress
    const findClosest = (arr, num) => {
      if (arr == null) {
        return
      }
      return arr.reduce((prev, current) =>
        Math.abs(current - num) < Math.abs(prev - num) ? current : prev
      )
    }

    const closestValue = computed(() => findClosest(progressvalues, myNumber.value))

    const getColor = computed(() => mylist.find((x) => x.progress == closestValue.value).color)

    return { myNumber, getColor }
  },
}
</script>
