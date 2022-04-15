<template>
  <div class="card-body pt-3" style="height: 200px">
    <div class="container-md">
      <div class="row" style="height: 50px">
        <Slider
          id="slider"
          v-model="value"
          :format="format"
          class="slider-blue"
          :max="max"
          :step="step"
          :options="{
            pips: {
              values: [0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100],
              mode: 'positions',
            },
          }"
        />
      </div>
    </div>
    <vue3-slider
      hidden
      v-model="value"
      color="#198754"
      track-color="#aefbc5"
      :max="30000"
      :step="1000"
      :tooltip="true"
      tooltipText="%v"
      tooltipColor="#FFFFFF"
      tooltipTextColor="#000000"
      :height="20"
    />
  </div>
</template>

<script>
import Slider from "@vueform/slider";
import slider from "vue3-slider";
export default {
  components: { Slider, "vue3-slider": slider },
  data: () => ({
    step: 1000,
    value: 29000,
    // format: {
    //   suffix: " RUB",
    // },
    max: 30000,
    showTooltip: "drag",
  }),
  methods: {
    format: function (value) {
      return `${Math.round(value)} RUB`;
    },
  },
};
</script>

<style>
.slider-red {
  --slider-connect-bg: #ef4444;
  --slider-tooltip-bg: #ef4444;
  --slider-handle-ring-color: #ef444430;
}
.slider-pips {
  display: flex;
  justify-content: space-evenly;
}
</style>
