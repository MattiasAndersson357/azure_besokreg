const formEl = document.querySelector('.form');
      formEl.addEventListener('submit', async (event) => {
        event.preventDefault();

        const data = {
          name: formEl.querySelector('[name="name"]').value,
          email: formEl.querySelector('[name="email"]').value
        };
        

        try {
          const res = await fetch('https://function-individuella-ghgsevcnfdcdbqhs.uksouth-01.azurewebsites.net/api/Besokreg?', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
          });

          if (!res.ok) throw new Error(await res.text());

          const json = await res.json();
          console.log('Response backend:', json);
          alert('Sent successfully');
        } catch (err) {
          console.error('Error:', err);
          alert('Something went wrong, check the console.');
        }
      });