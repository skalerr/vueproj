<template>
  <nav class="sticky-top navbar navbar-expand-xl navbar-light">
    <div class="container-fluid">
      <!-- <a class="" href="#"></a> -->
      <router-link class="navbar-brand" to="/">Калькулятор займов</router-link>
      <button
        class="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#navbarSupportedContent"
        aria-controls="navbarSupportedContent"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0 top-menu">
          <li class="nav-item">
            <!-- <a class="nav-link active" aria-current="page" href="#">Главная</a> -->
            <router-link class="nav-link active" to="/">Главная</router-link>
          </li>
          <li class="nav-item">
            <!-- <a class="nav-link" href="#">О нас</a> -->
            <router-link class="nav-link" to="/list">List Of loan</router-link>
          </li>
          <!-- выпадающий список -->
          <li class="nav-item dropdown">
            <a
              class="nav-link dropdown-toggle"
              href="#"
              id="navbarDropdown"
              role="button"
              data-bs-toggle="dropdown"
              aria-expanded="false"
            >
              Наши тарифы
            </a>
            <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
              <li><a class="dropdown-item" href="#">Action</a></li>
              <li><a class="dropdown-item" href="#">Another action</a></li>
              <li><hr class="dropdown-divider" /></li>
              <li><a class="dropdown-item" href="#">Something else here</a></li>
            </ul>
          </li>
          <li class="nav-item">
            <a class="nav-link disabled" href="#" tabindex="-1" aria-disabled="true">тест</a>
          </li>
        </ul>

        <!-- правое меню  -->
        <ul class="navbar-nav ms-auto mb-2 mb-lg-0 top-menu">
          <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="#"></a>
          </li>
          <!-- правое меню выпадающий список -->
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown"
              ><i class="fa-solid fa-user-astronaut"></i
            ></a>
            <ul class="dropdown-menu dropdown-menu-dark" aria-labelledby="navbarDropdownMenuLink">
              <li>
                <a
                  class="dropdown-item mb-2"
                  data-bs-toggle="modal"
                  data-bs-target="#exampleModal"
                  href="#"
                  >Регистрация</a
                >
              </li>
              <!-- <hr class="dropdown-divider"> bg-success bg-primary -->
              <li><a class="dropdown-item" href="#">Авторизация</a></li>
            </ul>
          </li>
          <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="#"
              ><i class="fa-solid fa-cart-arrow-down"></i
            ></a>
          </li>
        </ul>

        <form class="d-flex">
          <input class="form-control me-2" type="search" placeholder="Поиск" aria-label="Search" />
          <!-- поиск -->

          <button class="btn btn-outline-success disabled" type="submit">Искать!</button>
        </form>
      </div>
    </div>
  </nav>
</template>

<script>
export default {
  name: "navigation",
  props: {},
};
</script>

<style></style>
