import React from 'react';

import './App.css';
import MyComponent from './MyComponent';
import MyComponent2 from './MyComponent2';

type Props = {}
function App(props: Props) {
  return (
    <>
      <MyComponent napis='To jest property' />
      <MyComponent2 date={new Date()} price={34.90} />
    </>

  );
}

export default App;
