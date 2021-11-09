import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import CustomerList from './CustomerList';
import reportWebVitals from './reportWebVitals';

// import App from './App';
// import LifeCycleComponent from './LifeCycleComponent';
// import MyComponent from './MyComponent';
// import MyOtherComponent from './MyOtherComponent';
// import MyClassComponent from './MyClassComponent';

ReactDOM.render(
  <React.StrictMode>    
    { /* This is a comment in jsx (javascript + xml) syntax */ }
    { /* <App /> */ }
    <CustomerList />
    {/* <OrderList /> */}
    
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
